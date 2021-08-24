//  action responsavel por trocar o valor do modulo e da lesson
export function toggleLesson(module, lesson) {
  return {
    type: "TOGGLE_LESSON",
    module,
    lesson,
  };
}
