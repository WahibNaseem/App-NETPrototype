import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Message } from 'src/_models/message';
import { Observable, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MessageService {

  private apiurl = 'https://localhost:5001/api';
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private httpClient: HttpClient) { }


  /** GET: all the messages from the server */
  get(): Observable<Message[]> {
    return this.httpClient.get<Message[]>(this.apiurl + '/BroadCastMessages/desktop', this.httpOptions).pipe(
      tap(_ => console.log('fetched all the messages'))
    );
  }

  /** POST: send the message */
  sendMessage(message: Message): Observable<Message> {
    return this.httpClient.post<Message>(this.apiurl + '/BroadCastMessages/message', message, this.httpOptions)
      .pipe(
        tap(_ => console.log('Message sent successfully'))
      );
  }
}
