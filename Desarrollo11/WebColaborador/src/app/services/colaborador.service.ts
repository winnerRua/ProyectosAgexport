import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Colaborador } from '../models/colaborador';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ColaboradorService {

  constructor(private http:HttpClient) { }

  url:string = "https://localhost:44366/api/Colaborador";

  getColaborador(){
    return this.http.get(this.url);
  }

  addColaborador(colaborador:Colaborador):Observable<Colaborador>{
    return this.http.post<Colaborador>(this.url, colaborador);
  }

  updateColaborador(id:number, colaborador:Colaborador):Observable<Colaborador>{
    return this.http.put<Colaborador>(this.url + `/${id}`, colaborador);
  }

  deleteColaborador(id:number){
    return this.http.delete(this.url + `/${id}`);
  }
}
