import React from 'react';
import {Redirect, Route, Switch } from "react-router-dom";
import './App.css';
import Feed from './components/feed';
import PostEdit from './components/postEdit';

function App() {
  return (
    <React.Fragment>
      <main className="container">
        <Switch>
          <Route path="/postEdit/:id" component={PostEdit} />
          <Route path="/feed" component={Feed} />
          <Redirect from="/" exact to="/feed" />
        </Switch>
      </main>
    </React.Fragment>
  );
}

export default App;
