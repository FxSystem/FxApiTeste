import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any ;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }

  getEventos(){
    this.eventos = this.http.get('http://localhost:3000/api/values').subscribe(response => {
      this.eventos = response;
      console.log();
    }, error => {
      console.log(error);
      
    });
      
    
  }


}
