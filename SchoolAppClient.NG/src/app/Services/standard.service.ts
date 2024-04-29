import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Standard } from '../Models/standard';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StandardService {

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }




  apiUrl: string = "https://localhost:7225/api/Standards";

  public GetStandards(): Observable<Standard[]> {

    return this.http.get<Standard[]>(this.apiUrl);
  }
  public GetStandardbyID(id: number): Observable<Standard> {

    return this.http.get<Standard>(this.apiUrl + '/' + id);
  }
  public SaveStandard(standard: any): Observable<any> {

    return this.http.post(this.apiUrl, JSON.stringify(standard), this.httpOptions);
  }
  public UpdateStandard(standard: Standard): Observable<Standard> {

    return this.http.put<Standard>(this.apiUrl + '/' + standard.standardId, JSON.stringify(standard), this.httpOptions);
  }
  public DeleteStandard(id: number): Observable<any> {

    return this.http.delete(this.apiUrl + '/' + id);
  }


}
