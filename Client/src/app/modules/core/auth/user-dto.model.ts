import { RoleDto } from './role-dto.model';

export interface UserDto {
  id: string;
  username: string;
  email: string;
  phoneNumber: number;
  token: string;
  isActive: boolean;
  roles: RoleDto[];
}
