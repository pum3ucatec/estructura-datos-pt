#!/bin/bash

# Detecta la rama actual
current_branch=$(git rev-parse --abbrev-ref HEAD)

# Sincroniza con el remoto usando rebase
git pull --rebase origin "$current_branch"

# Verifica si hay cambios (modificados, nuevos o eliminados)
if [[ -n $(git status --porcelain) ]]; then
    git add .
    git commit -m "Actualización automática de ejercicios"
    git push origin "$current_branch"
    echo "✅ Cambios subidos en la rama '$current_branch'."
else
    echo "🟡 No hay cambios para subir en '$current_branch'."
fi