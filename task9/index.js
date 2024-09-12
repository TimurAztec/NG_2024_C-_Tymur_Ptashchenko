document.addEventListener('DOMContentLoaded', () => {
    const taskForm = document.getElementById('task__form');
    const taskInput = document.getElementById('task__form__input');
    const todoList = document.getElementById('todo__list');

    let draggedItem = null;

    taskForm.addEventListener('submit', (e) => {
        e.preventDefault();
        const taskText = taskInput.value.trim();
        if (taskText !== '') {
            addTask(taskText);
            taskInput.value = '';
        }
    });

    function addTask(taskText) {
        const task = document.createElement('li');
        task.classList.add('task');
        task.setAttribute('draggable', 'true');
        task.innerHTML = `
            <span>${taskText}</span>
            <div>
                <button class="complete_btn">✔️</button>
                <button class="delete_btn">🗑️</button>
            </div>
        `;
        task.completed = false;

        todoList.appendChild(task);
        addDragAndDropEvents(task);
    }

    function addDragAndDropEvents(task) {
        task.addEventListener('dragstart', () => {
            draggedItem = task;
            task.classList.add('dragging');
        });

        task.addEventListener('dragend', () => {
            draggedItem = null;
            task.classList.remove('dragging');
        });

        task.querySelector('.complete_btn').addEventListener('click', () => {
            task.completed = !task.completed;
            task.classList.toggle('completed');
            task.querySelector('.complete_btn').innerHTML = task.completed ? '❌' : '✔️';
        });

        task.querySelector('.delete_btn').addEventListener('click', () => {
            task.remove();
        });
    }

    todoList.addEventListener('dragover', (e) => {
        e.preventDefault();
        const afterElement = getDragAfterElement(todoList, e.clientY);
        if (draggedItem) {
            if (!afterElement) {
                todoList.appendChild(draggedItem);
            } else {
                todoList.insertBefore(draggedItem, afterElement);
            }
        }
    });

    function getDragAfterElement(container, y) {
        const draggableElements = [...container.querySelectorAll('.task:not(.dragging)')];

        return draggableElements.reduce((closest, child) => {
            const box = child.getBoundingClientRect();
            const offset = y - box.top - box.height / 2;
            if (offset < 0 && offset > closest.offset) {
                return { offset: offset, element: child };
            } else {
                return closest;
            }
        }, { offset: Number.NEGATIVE_INFINITY }).element;
    }
});
