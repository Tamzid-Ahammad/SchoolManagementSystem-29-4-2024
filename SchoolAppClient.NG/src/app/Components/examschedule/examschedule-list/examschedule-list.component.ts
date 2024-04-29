import { Component, OnInit } from '@angular/core';
import { ExamSchedule } from '../../../Models/exam-schedule';
import { ExamScheduleService } from '../../../Services/exam-schedule.service';
import { ExamScheduleVM } from '../../../Models/exam-schedule-vm';
import { Router } from '@angular/router';

@Component({
  selector: 'app-examschedule-list',
  templateUrl: './examschedule-list.component.html',
  styleUrl: './examschedule-list.component.css'
})
export class ExamscheduleListComponent implements OnInit {

  public examSchedules !: ExamScheduleVM[];
  constructor(private examScheduleService: ExamScheduleService, private router: Router) { }

  ngOnInit(): void {
    this.LoadExamSchedules();
  }

  LoadExamSchedules() {
    this.examScheduleService.GetExamSchedules().subscribe
      (examSchedules => {
        this.examSchedules = examSchedules;
      });
  }

  //DeleteExamSchedules(id: number) {
  //  this.examScheduleService.DeleteExamSchedule(id).subscribe(() => {
  //    this.LoadExamSchedules();

  //  });
  //}
  deleteExamSchedules(id: number): void {
    if (confirm("Are you sure you want to delete this fee type?")) {
      this.examScheduleService.DeleteExamSchedule(id).subscribe(() => {

        this.examSchedules = this.examSchedules.filter(examSchedules => examSchedules.examScheduleId !== id);
      });
    }

  }






}
