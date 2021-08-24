import { combineReducers } from 'redux';

import course from './course';

// função do redux responsavel por combinar os reducers em um unico objeto
// objeto contendo todos os reducers
export default combineReducers({
    course,
});

