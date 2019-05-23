import React from "react";
import Navbar from "./Navbar/Navbar";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import Home from "./Home/Home";
import Counter from "./Counter/Counter";
import "../index.css";

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
