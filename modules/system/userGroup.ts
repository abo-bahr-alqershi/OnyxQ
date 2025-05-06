import { Entity, PrimaryGeneratedColumn, Column, OneToMany } from 'typeorm';
import { User } from './user';

@Entity('USER_GROUPS')
export class UserGroup {
  @PrimaryGeneratedColumn({ name: 'GROUP_ID' })
  id: number;

  @Column({ name: 'GROUP_NAME', length: 100 })
  name: string;

  @Column({ name: 'GROUP_DESC', length: 200, nullable: true })
  description: string;

  @Column({ name: 'IS_ACTIVE', type: 'number', default: 1 })
  isActive: number;

  @Column({ name: 'IS_ADMIN', type: 'number', default: 0 })
  isAdmin: number;

  @Column({ name: 'CREATED_DATE', type: 'date', nullable: true })
  createdDate: Date;

  @Column({ name: 'MODIFIED_DATE', type: 'date', nullable: true })
  modifiedDate: Date;

  @OneToMany(() => User, user => user.userGroup)
  users: User[];
} 