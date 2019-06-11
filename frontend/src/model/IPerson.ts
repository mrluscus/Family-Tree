import {IEntity} from './IEntity';
import {IGender} from './IGender';

export interface IPerson extends IEntity {
  firstName: string;
  lastName: string;
  patronymicName?: string;
  birthDate?: string | null;
  deathDate?: string | null;
  biography?: string;
  genderId: number;
  gender: IGender;
}
