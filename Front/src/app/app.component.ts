import { Component } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Mechanic } from './Mechanic';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  mechanics : any;
  title = 'Prueba Ivan Villamil';

  constructor(
      public http: HttpClient
  ){}


  ngOnInit() {

    this.getProductos().subscribe((response) => {
      if (response) {
        this.mechanics = response;
console.log(this.mechanics);
      } else {
        console.log("No se encontro persona");
      }
    })
  }

  getProductos(): Observable<any>{
    return this.http.get<Mechanic>('http://localhost:40715/Mechanic/v1');
  }

}
