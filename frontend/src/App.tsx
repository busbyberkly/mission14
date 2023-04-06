import React from "react";

import "./App.css";
import Header from "./Header";
import MovieList from "./movie/MovieList";

function App() {
  return (
    <div className="App">
      <Header slogan="Rut Ro Raggy! -Mission14_bzp123" />
      <MovieList />
    </div>
  );
}

export default App;
