export interface IEntity {
  id: number;
}

export interface INamedEntity extends IEntity {
  name: string;
}

export interface ICreatedEntity {
  created_at: string;
}

export interface IEditedEntity extends ICreatedEntity {
  updated_at: string;
}

export interface ITrackedEntity extends IEditedEntity {
  deleted_at: string | null;
}
