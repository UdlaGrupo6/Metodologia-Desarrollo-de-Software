import { Injectable } from '@angular/core';
import { LoginI } from '../../modelos/login.inteface';
import { ResponseI } from '../../modelos/response.interface';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ApiService {

  url:string = 'http://apiservicios.ecuasolmovsa.com:3009/api/Usuarios?'

  constructor(private http: HttpClient) { }

  loginbyUser(form:LoginI): Observable<ResponseI>{
    let direccion = this.url;
    return this.http.post<ResponseI>(direccion,form)
  }
}
