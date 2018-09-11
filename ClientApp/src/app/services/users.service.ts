import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: Http) { }

  public getUsers() {
    return this.http.get(`${environment.baseUrl}/users/all`);
  }
}
