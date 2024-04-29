import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ExamSchedule } from '../Models/exam-schedule';
import { Observable } from 'rxjs';
import {GetExamScheduleOptionsResponse} from "../Models/get-exam-schedule-options-response";
import { ExamScheduleVM } from '../Models/exam-schedule-vm';

@Injectable({
  providedIn: 'root'
})
export class ExamScheduleService {

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',

    })
  }
  httpFormOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'multipart/form-data',

    })
  }

  apiUrl: string = "https://localhost:7225/api/ExamSchedules";

  public GetExamSchedules(): Observable<ExamScheduleVM[]> {
    return this.http.get<ExamScheduleVM[]>(this.apiUrl);
  }

  public GetExamScheduleOptions(): Observable<GetExamScheduleOptionsResponse[]> {
    return this.http.get<GetExamScheduleOptionsResponse[]>(this.apiUrl+'/GetExamScheduleOptions');
  }

  public GetExamScheduleById(id: number): Observable<ExamScheduleVM> {
    return this.http.get<ExamScheduleVM>(this.apiUrl + '/' + id);
  }

  public SaveExamSchedule(examSchedule: ExamSchedule): Observable<any> {
    return this.http.post<ExamSchedule>(this.apiUrl, examSchedule, this.httpOptions);
  }

  public UpdateExamSchedule(examSchedule: ExamSchedule): Observable<ExamSchedule> {
    return this.http.put<ExamSchedule>(this.apiUrl + '/' + examSchedule.examScheduleId, examSchedule, this.httpOptions);
  }
  public DeleteExamSchedule(id: number): Observable<ExamSchedule> {
    return this.http.delete<ExamSchedule>(this.apiUrl + '/' + id);
  }



}
