import { Entity, PrimaryGeneratedColumn, Column, ManyToOne } from 'typeorm';
import { User } from './user';

@Entity('USER_PRIVILEGE')
export class UserPrivilege {
  @PrimaryGeneratedColumn({ name: 'PRIV_ID' })
  id: number;

  @Column({ name: 'SCR_NO', type: 'number' })
  screenId: number;

  @Column({ name: 'CAN_VIEW', type: 'number', default: 0 })
  canView: number;

  @Column({ name: 'CAN_ADD', type: 'number', default: 0 })
  canAdd: number;

  @Column({ name: 'CAN_EDIT', type: 'number', default: 0 })
  canEdit: number;

  @Column({ name: 'CAN_DELETE', type: 'number', default: 0 })
  canDelete: number;

  @Column({ name: 'CAN_PRINT', type: 'number', default: 0 })
  canPrint: number;

  @Column({ name: 'CAN_APPROVE', type: 'number', default: 0 })
  canApprove: number;

  @ManyToOne(() => User, user => user.privileges)
  @Column({ name: 'U_ID' })
  user: User;
} 