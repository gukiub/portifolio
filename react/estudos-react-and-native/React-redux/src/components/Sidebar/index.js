import React from "react";

import { connect } from "react-redux";
import { bindActionCreators } from "redux"

import * as CourseActions from "../../store/actions/course";

const Sidebar = ({ modules, toggleLesson }) => (
  <aside>
    {modules.map((module) => (
      <div key={module.id}>
        <strong>{module.title}</strong>
        <ul>
          {module.lessons.map((lesson) => (
            <li key={lesson.id}>
              {lesson.title}{" "}
              <button onClick={() => toggleLesson(module, lesson)}>
                Selecionar
              </button>
            </li>
          ))}
        </ul>
      </div>
    ))}
  </aside>
);

const mapStateToProps = (state) => ({
  modules: state.course.modules,
});

const mapDispatchToProps = (dispatch) =>
  bindActionCreators(CourseActions, dispatch);
// repassa os valores do estado e a alteração para as funções acima e retorna na sidebar
export default connect(mapStateToProps, mapDispatchToProps)(Sidebar);
