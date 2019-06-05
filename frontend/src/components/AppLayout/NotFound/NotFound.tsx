import React from 'react';
import styled from 'styled-components';
import ColorPalette from '../../../constants/ColorPalette';
import Typography from '../../../constants/Typography';
import Icon, {IconName} from '../../Icon/Icon';
import {Button, Row, Col} from 'antd';
import 'antd/dist/antd.css';
import history from '../../../helpers/History';

function NotFound() {
  const NotFoundPage = styled.div`
    width: 100%;
    height: 100%;
    background-color: ${ColorPalette.gray1};
  `;

  const Sign404 = styled.span`
    font-size: ${Typography.size.huge};
    font-weight: ${Typography.weight.bold};
    color: ${ColorPalette.gray7};
  `;

  const Text404 = styled.span`
    font-size: ${Typography.size.medium};
    color: ${ColorPalette.gray6};
  `;

  return (
    <NotFoundPage>
      <Row type="flex" justify="center" align="top" style={{paddingTop: '60px'}}>
        <Col>
          <Row type="flex" align="middle">
            <Icon name={IconName.NotFound} size={400} style={{marginRight: '70px'}} />

            <Col>
              <Row>
                <Sign404>404</Sign404>
              </Row>
              <Row>
                <Text404>Sorry, the page you visited does not exist</Text404>
              </Row>
              <Row>
                <Button type="primary" style={{marginTop: '20px'}} onClick={() => history.push('/')}>
                  Back to Home
                </Button>
              </Row>
            </Col>
          </Row>
        </Col>
      </Row>
    </NotFoundPage>
  );
}

export default NotFound;
