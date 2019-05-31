import React from 'react';
import './Navbar.css';
import {NavLink} from 'react-router-dom';
import Icon, {IconName} from '../../Icon/Icon';

function Navbar() {
  return (
    <nav className="navbar navbar-expand-lg navbar-light bg-light d-flex">
      <NavLink className="navbar-brand" to="/">
        <Icon name={IconName.Tree} size={30} style={{marginRight: '10px'}} />
        Home
      </NavLink>

      <div className="d-flex">
        <NavLink className="nav-link" to="/my-family">
          My Family
        </NavLink>
        <NavLink className="nav-link" to="/photo-album/">
          Photo Album
        </NavLink>
      </div>

      <form className="form-inline my-2 my-lg-0 ml-auto">
        <input className="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" />
        <button className="btn btn-outline-success my-2 my-sm-0" type="submit">
          Search
        </button>
      </form>
    </nav>
  );
}

export default Navbar;
