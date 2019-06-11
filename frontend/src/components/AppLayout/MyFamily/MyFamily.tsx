import React from 'react';
import {IColumn, ColumnType} from '../../Common/Datagrid/IColumn';
import {IPerson} from '../../../model/IPerson';
import DataGrid from '../../Common/Datagrid/DataGrid';
import {createFakePersons} from '../../../helpers/FakeData';
import moment from 'moment';
import {FRONTEND_DATE} from '../../../constants/Date';
import styled from 'styled-components';
import PageContent from '../../Common/PageContent';
import ScrollableContainer from '../../Common/ScrollableContainer';

function MyFamily() {
  const ButtonPanel = styled.div`
    padding-bottom: 24px;
  `;

  function dataColumns(): Array<IColumn<IPerson>> {
    return [
      {
        id: 'firstName',
        header: 'Имя',
        type: ColumnType.Text,
        cell: item => <span>{item.firstName}</span>
      },
      {
        id: 'lastName',
        header: 'Фамилия',
        type: ColumnType.Text,
        cell: item => <span>{item.lastName}</span>
      },
      {
        id: 'patronymicName',
        header: 'Отчество',
        type: ColumnType.Text,
        cell: item => <span>{item.patronymicName}</span>
      },
      {
        id: 'birthDate',
        header: 'Дата рождения',
        type: ColumnType.Text,
        cell: item => <span>{item.birthDate ? moment(new Date(item.birthDate)).format(FRONTEND_DATE) : ''}</span>
      },
      {
        id: 'deathDate',
        header: 'Дата смерти',
        type: ColumnType.Text,
        cell: item => <span>{item.deathDate ? moment(new Date(item.deathDate)).format(FRONTEND_DATE) : ''}</span>
      },
      {
        id: 'gender',
        header: 'Пол',
        type: ColumnType.Text,
        cell: item => <span>{item.gender.name}</span>
      }
    ];
  }

  // TODO: Add real data
  const fakeData = createFakePersons(10);

  return (
    <PageContent>
      <ScrollableContainer>
        <ButtonPanel>
          <button className="btn btn-outline-primary" style={{marginRight: '24px'}}>
            Add person
          </button>
          <button className="btn btn-outline-primary">Add relationsip</button>
        </ButtonPanel>

        <DataGrid columnsDefinition={dataColumns()} dataSource={fakeData} />
      </ScrollableContainer>
    </PageContent>
  );
}

export default MyFamily;
