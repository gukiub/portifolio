import React from "react";

import { connect } from "react-redux";

const Video = ({ activeModule, activeLesson }) => (
  <div>
    <strong>Módulo: {activeModule.title}</strong>
    <br />
    <span>Aula: {activeLesson.title}</span>
  </div>
);

// conecta ao redux para retirar o estado do state passando pro mapStateToProps 
export default connect((state) => ({
  activeLesson: state.course.activeLesson,
  activeModule: state.course.activeModule,
}))(Video);
