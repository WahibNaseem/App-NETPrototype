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
  message = new Message('', 'Web');
  constructor(private messageService: MessageService) { }
  ngOnInit() {
    this.refresh();
  }

  sendMessage() {
    this.messageService.sendMessage(this.message).subscribe(() => {
      this.refresh();
      this.message.text = '';
    });

  }

  getMessages() {
    this.messageService.get().subscribe(response => this.messages = response);
  }

  refresh() {
    this.getMessages();
  }

}
