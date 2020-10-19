import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PhoneService {
url="/api/phone";
  constructor(private http:HttpClient) { }
public getPhone(id){
 return this.http.get(this.url+ '/'+ id);
}
}
