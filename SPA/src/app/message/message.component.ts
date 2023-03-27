import { Component, OnInit } from '@angular/core';
import { Message } from 'src/_models/message';
import { MessageService } from 'src/_services/message.service';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.css']
})
export class MessageComponent implements OnInit {

  messages: Message[] = [];
  message = new Message('', 'web');
  constructor(private messageService: MessageService) { }
  ngOnInit() {
  }

  sendMessage() {
    this.messageService.sendMessage(this.message).subscribe(() => {
      this.getMessages();
      this.message.text = '';
    });

  }

  getMessages() {
    this.messageService.get().subscribe(response => this.messages = response);
  }



}
