import { Entity, PrimaryGeneratedColumn, Column, OneToMany } from 'typeorm';
import { Branch } from './branch';

@Entity('COMPANY')
export class Company {
  @PrimaryGeneratedColumn({ name: 'CMP_NO' })
  id: number;

  @Column({ name: 'CMP_A_NAME', length: 100 })
  arabicName: string;

  @Column({ name: 'CMP_E_NAME', length: 100, nullable: true })
  englishName: string;

  @Column({ name: 'CMP_ADDRESS', length: 250, nullable: true })
  address: string;

  @Column({ name: 'CMP_LOGO', type: 'blob', nullable: true })
  logo: Buffer;

  @Column({ name: 'CMP_PHONE', length: 16, nullable: true })
  phone: string;

  @Column({ name: 'CMP_FAX', length: 16, nullable: true })
  fax: string;

  @Column({ name: 'CMP_EMAIL', length: 60, nullable: true })
  email: string;

  @Column({ name: 'CMP_WEBSITE', length: 100, nullable: true })
  website: string;

  @Column({ name: 'CMP_CRNBR', length: 20, nullable: true })
  commercialRegistrationNumber: string;

  @Column({ name: 'CMP_TAXNBR', length: 20, nullable: true })
  taxNumber: string;

  @Column({ name: 'FISCAL_YEAR_START', type: 'date', nullable: true })
  fiscalYearStart: Date;

  @Column({ name: 'FISCAL_YEAR_END', type: 'date', nullable: true })
  fiscalYearEnd: Date;

  @OneToMany(() => Branch, branch => branch.company)
  branches: Branch[];
} 