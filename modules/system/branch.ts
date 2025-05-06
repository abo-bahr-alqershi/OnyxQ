import { Entity, PrimaryGeneratedColumn, Column, ManyToOne, OneToMany } from 'typeorm';
import { Company } from './company';
import { Warehouse } from '../inventory/warehouse';
import { User } from './user';

@Entity('ALL_BRANCHES')
export class Branch {
  @PrimaryGeneratedColumn({ name: 'BRN_NO' })
  id: number;

  @Column({ name: 'BRN_NAME', length: 100 })
  name: string;

  @Column({ name: 'BRN_E_NAME', length: 100, nullable: true })
  englishName: string;

  @Column({ name: 'BRN_ADDRESS', length: 250, nullable: true })
  address: string;

  @Column({ name: 'BRN_PHONE', length: 16, nullable: true })
  phone: string;

  @Column({ name: 'BRN_FAX', length: 16, nullable: true })
  fax: string;

  @Column({ name: 'BRN_EMAIL', length: 60, nullable: true })
  email: string;

  @Column({ name: 'INACTIVE', type: 'number', default: 0 })
  isInactive: number;

  @Column({ name: 'IS_MAIN', type: 'number', default: 0 })
  isMain: number;

  @ManyToOne(() => Company, company => company.branches)
  @Column({ name: 'CMP_NO' })
  company: Company;

  @OneToMany(() => Warehouse, warehouse => warehouse.branch)
  warehouses: Warehouse[];

  @OneToMany(() => User, user => user.branches)
  users: User[];
} 