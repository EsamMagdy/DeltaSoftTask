import { UserDto } from './../../core/auth/user-dto.model';
export interface Task {
  id: number;
  assignedToUserId: string;
  assignedToUser: UserDto;
  description: string;
  deliverDate: Date;
  creationTime: Date;
  markAsDone: boolean;
  isChecked: boolean;
}
