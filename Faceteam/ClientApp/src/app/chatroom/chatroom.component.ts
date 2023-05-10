import { Component, OnInit, Inject, Injectable } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms'
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-chatroom',
  templateUrl: './chatroom.component.html',
  styleUrls: ['./chatroom.component.css']
})
export class ChatroomComponent implements OnInit {
  userForm = new FormGroup({
    userName: new FormControl(''),
    roomId: new FormControl(''),
  });

  constructor(private http:HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    // sends post request to server, which will create a new room or use
    // an existing room id
    console.log(this.userForm.value);
    this.http.post(this.baseUrl + 'chatroom', this.userForm.value).subscribe(result => {
      console.log(result);
    }, error => console.error(error));

  }

}
