import * as React from 'react';
import {HTMLAttributes} from 'react';

import {ReactComponent as Tree} from './tree-2.svg';
import {ReactComponent as NotFound} from './not-found.svg';

export enum IconName {
  Tree,
  NotFound
}

const ICONS_MAP: {[key: number]: any} = {
  [IconName.Tree]: Tree,
  [IconName.NotFound]: NotFound
};

export interface IProps extends HTMLAttributes<unknown> {
  name: IconName;
  size?: number;
}

class Icon extends React.PureComponent<IProps> {
  public static defaultProps = {
    size: 20
  };

  public render() {
    const IconComponent = ICONS_MAP[this.props.name];

    return <IconComponent width={this.props.size} height={this.props.size} {...this.props} />;
  }
}

export default Icon;
