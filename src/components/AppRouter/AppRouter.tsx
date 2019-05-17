import React from "react";

import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import Home from "../Home/Home";
import Counter from "../Counter/Counter";
import { NavLink } from "react-router-dom";

function AppRouter() {
  return (
    <Router>
      <div>
        <nav className="NavBar">
          <NavLink to="/">Home</NavLink>
          <NavLink to="/counter/">Counter</NavLink>
        </nav>
        <hr />
        <Route path="/" exact component={Home} />
        <Route path="/counter/" component={Counter} />
      </div>
    </Router>
  );
}

export default AppRouter;
