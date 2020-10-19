import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MeToYouService {

  constructor(private http:HttpClient) { }
  url="/api/metoyou";
  public MtyAddRecord(newRecord){
 return this.http.post(this.url, newRecord);
  }
}
