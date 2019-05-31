import React from 'react';
import Navbar from '../components/Common/Navbar/Navbar';
import {BrowserRouter, Route, Switch} from 'react-router-dom';
import Home from '../components/AppLayout/Home/Home';
import PhotoAlbum from '../components/AppLayout/PhotoAlbum/PhotoAlbum';
import MyFamily from '../components/AppLayout/MyFamily/MyFamily';
import '../index.css';

export default function App() {
  return (
    <BrowserRouter>
      <div className="d-flex flex-column w-100">
        <Navbar />

        <div className="app-body">
          <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/my-family/" component={MyFamily} />
            <Route path="/photo-album/" component={PhotoAlbum} />
          </Switch>
        </div>
      </div>
    </BrowserRouter>
  );
}
