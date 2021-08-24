import React, { Component } from "react";
import { Provider } from "react-redux";

import Video from "./components/Video";
import Sidebar from "./components/Sidebar";

import store from "./store";

// declarando o provider e recebendo o store:
// Provider repassa o estado do store para todos os componentes filhos
class App extends Component {
  render() {
    return (
      <div className="app">
        <Provider store={store}>
          <Video />
          <Sidebar />
        </Provider>
      </div>
    );
  }
}

export default App;
