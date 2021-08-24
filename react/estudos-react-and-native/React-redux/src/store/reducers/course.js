// define o estado inicial com o qual a aplicação será iniciada
// informações da lista inicial que vai ser compartilhada com a aplicação
const INITIAL_STATE = {
  activeLesson: {},
  activeModule: {},
  modules: [
    {
      id: 1,
      title: "Iniciando com React",
      lessons: [
        { id: 1, title: "primeira aula" },
        { id: 2, title: "segunda aula" },
      ],
    },
    {
      id: 2,
      title: "Aprendendo a usar redux",
      lessons: [
        { id: 3, title: "Terceira aula" },
        { id: 4, title: "Quarta aula" },
      ],
    },
  ],
};

// devolve o estado e observa as mudanças de estado do objeto curso
export default function course(state = INITIAL_STATE, action) {
  if (action.type === "TOGGLE_LESSON") {
    return {
      ...state,
      activeLesson: action.lesson,
      activeModule: action.module,
    };
  }

  return state;
}
