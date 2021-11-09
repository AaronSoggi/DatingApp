import { HttpClient } from '@angular/common/http';
import { OnInit } from '@angular/core';
import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating App';
  users: any;

  constructor(private http: HttpClient) { } // declare thing we are about to inject as a private or public variable.
  
  ngOnInit() {
    this.getUsers();
  }

  public getUsers()
  {
    this.http.get('https://localhost:5001/api/Users').subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    })
  }
}
