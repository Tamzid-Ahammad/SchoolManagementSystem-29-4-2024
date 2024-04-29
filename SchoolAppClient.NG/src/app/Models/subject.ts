import { ExamSubject } from "./exam-subject";
import { Standard } from "./standard";

export class Subject {
  subjectId!: number;
  subjectName !: string;
  subjectCode!: number;
  standardId !: number;
  standard!: Standard;
  examSubjects: ExamSubject[]=[];
}
