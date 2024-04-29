import { ExamScheduleStandardForExamScheduleVM } from "./exam-schedule-standard-for-exam-schedule-vm";

export class ExamScheduleVM {
  examScheduleId !: number;
  examScheduleName !: string;
  examScheduleStandards !: ExamScheduleStandardForExamScheduleVM[];
}
