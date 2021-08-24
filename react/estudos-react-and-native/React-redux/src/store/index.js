import { createStore } from "redux";

import rootReducer from './reducers'

// função do redux responsavel por criar o store
// sendo passado como store uma lista de reducers
const store = createStore(rootReducer);

export default store;
