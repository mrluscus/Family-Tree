import faker from 'faker';
import {IPerson} from '../model/IPerson';
import {IGender} from '../model/IGender';

export function createFakeGender(): IGender {
  let gender = ['Male', 'Female', 'Unknown'];

  return {
    id: faker.random.number(),
    code: faker.random.arrayElement(gender).toLowerCase(),
    name: faker.random.arrayElement(gender)
  };
}

export function createFakePerson(): IPerson {
  var gender = createFakeGender();

  return {
    id: faker.random.number(),
    firstName: faker.name.firstName(),
    lastName: faker.name.lastName(),
    patronymicName: faker.name.lastName(),
    birthDate: faker.date.past().toDateString(),
    deathDate: faker.date.past().toDateString(),
    biography: faker.random.words(),
    gender: gender,
    genderId: gender.id
  };
}

export function createFakePersons(count: number): any {
  var persons: IPerson[] = [];
  for (let i = 0; i < count; i++) {
    persons.push(createFakePerson());
  }
  return persons;
}
