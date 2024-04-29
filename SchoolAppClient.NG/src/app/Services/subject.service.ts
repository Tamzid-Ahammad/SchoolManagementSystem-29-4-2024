import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Subject } from '../Models/subject';

@Injectable({
  providedIn: 'root'
})
export class SubjectService {

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }




  apiUrl: string = "https://localhost:7225/api/Subjects";

  public GetSubjects(): Observable<Subject[]> {

    return this.http.get<Subject[]>(this.apiUrl);
  }
  public GetSubjectsbyID(id: number): Observable<Subject> {

    return this.http.get<Subject>(this.apiUrl + '/' + id);
  }
  public SaveSubject(subject: any): Observable<any> {

    return this.http.post(this.apiUrl, JSON.stringify(subject), this.httpOptions);
  }
  public UpdateSubject(standard: Subject): Observable<Subject> {

    return this.http.put<Subject>(this.apiUrl + '/' + standard.standardId, JSON.stringify(standard), this.httpOptions);
  }
  public DeleteSubject(id: number): Observable<any> {

    return this.http.delete(this.apiUrl + '/' + id);
  }
}
