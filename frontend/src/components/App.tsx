import React from 'react';
import Navbar from '../components/Common/Navbar/Navbar';
import {Route, Switch, Router} from 'react-router-dom';
import Home from '../components/AppLayout/Home/Home';
import PhotoAlbum from '../components/AppLayout/PhotoAlbum/PhotoAlbum';
import NotFound from '../components/AppLayout/NotFound/NotFound';
import MyFamily from '../components/AppLayout/MyFamily/MyFamily';
import '../index.css';
import history from '../helpers/History';

export default function App() {
  return (
    <Router history={history}>
      <div className="d-flex flex-column w-100">
        <Navbar />

        <div className="app-body">
          <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/my-family/" component={MyFamily} />
            <Route path="/photo-album/" component={PhotoAlbum} />
            <Route path="*" component={NotFound} />
          </Switch>
        </div>
      </div>
    </Router>
  );
}
