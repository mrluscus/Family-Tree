import React from 'react';
import Navbar from '../components/Common/Navbar/Navbar';
import {BrowserRouter, Route, Switch} from 'react-router-dom';
import Home from '../components/AppLayout/Home/Home';
import Counter from '../components/AppLayout/Counter/Counter';
import '../index.css';

export default function App() {
  return (
    <BrowserRouter>
      <div className="d-flex flex-column w-100">
        <Navbar />

        <div className="app-body">
          <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/counter/" component={Counter} />
          </Switch>
        </div>
      </div>
    </BrowserRouter>
  );
}
