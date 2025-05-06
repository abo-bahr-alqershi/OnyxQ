import { Entity, PrimaryGeneratedColumn, Column, ManyToOne, OneToMany, ManyToMany, JoinTable } from 'typeorm';
import { Branch } from './branch';
import { UserGroup } from './userGroup';
import { UserPrivilege } from './userPrivilege';

@Entity('USER_R')
export class User {
  @PrimaryGeneratedColumn({ name: 'U_ID' })
  id: number;

  @Column({ name: 'U_NAME', length: 60 })
  name: string;

  @Column({ name: 'U_PASS', length: 100 })
  password: string;

  @Column({ name: 'U_FULL_NAME', length: 200, nullable: true })
  fullName: string;

  @Column({ name: 'U_ACTIVE', type: 'number', default: 1 })
  isActive: number;

  @Column({ name: 'U_EMAIL', length: 60, nullable: true })
  email: string;

  @Column({ name: 'U_MOBILE', length: 20, nullable: true })
  mobile: string;
  
  @Column({ name: 'LAST_LOGIN_DATE', type: 'date', nullable: true })
  lastLoginDate: Date;

  @Column({ name: 'CREATED_DATE', type: 'date', nullable: true })
  createdDate: Date;

  @Column({ name: 'MODIFIED_DATE', type: 'date', nullable: true })
  modifiedDate: Date;

  @Column({ name: 'MUST_CHANGE_PASS', type: 'number', default: 0 })
  mustChangePassword: number;

  @ManyToOne(() => UserGroup, userGroup => userGroup.users)
  @Column({ name: 'GROUP_ID', nullable: true })
  userGroup: UserGroup;

  @ManyToMany(() => Branch)
  @JoinTable({
    name: 'USER_BRANCH',
    joinColumn: { name: 'U_ID', referencedColumnName: 'id' },
    inverseJoinColumn: { name: 'BRN_NO', referencedColumnName: 'id' }
  })
  branches: Branch[];

  @OneToMany(() => UserPrivilege, userPrivilege => userPrivilege.user)
  privileges: UserPrivilege[];
} 