import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HubConnection } from '@aspnet/signalr-client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  chatMessages: ChatMessage[];
  newMessage: string;
  name: string;
  hub: HubConnection;

  constructor(private httpclient: HttpClient) {
    this.chatMessages = [];

    // SignalR

    this.hub = new HubConnection('/chats');
    this.hub.start().then(() => {
      this.hub.on('messages', (data: any) => {
        this.chatMessages.unshift(data);
      });
    });

    this.fetchMessages();
  }

  onReload() {
    this.fetchMessages();
  }

  fetchMessages() {
    this.httpclient.get<ChatMessage[]>('api/chatmessages').subscribe(
      (messages) => this.chatMessages = messages.reverse()
    );
  }

  onSubmit() {

    // With SignalR ...

    this.hub.send('messages', { text: this.newMessage, name: this.name });
    this.newMessage = '';

    // .. or with REST

    // this.httpclient.post<ChatMessage>('api/chatmessages', { text: this.newMessage, name: this.name }).subscribe(
    //   (res) => {
    //     this.fetchMessages();
    //     this.newMessage = '';
    //   }
    // );
  }
}

interface ChatMessage {
  text: string;
  name: string;
}
