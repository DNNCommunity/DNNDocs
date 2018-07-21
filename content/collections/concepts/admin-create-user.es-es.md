---
title: Admin - Crear un usuario
slug: admin-create-user
---

# Crear un usuario (Admin)

Pueden crearse usuarios mediante la API (Desarrolladores), Prompt (Administradores/Hosts) o desde el interface de usuario dentro de DNN (Administradores). 

---
## Prerrequisitos
* Una cuenta de administrador para el sitio web

## Pasos

1. Vaya a **Persona Bar > Gestionar > Usuarios**.

  ![](/img/concepts/admin-create-a-user-pbar.png "Persona bar crear usuario")	

2. Pulse **Añadir usuario**.

  ![](/img/concepts/admin-create-a-user-add-user-btn.png "Pantalla de crear usuario")

3. Escriba la información del usuario.

  ![](/img/concepts/admin-add-user-user-info-screen.png "Pantalla de información de usuario")


|**Campo** | **Descripción**|
|---|---|
| **Autorizado** | Si está activado (**On**), el usuario es inmediatamente suscrito al rol **Registered User** y a otros roles que tengan la **Asignación automática** actiivada. Si no está activado (**Off**), la cuenta del usuario es creada pero no autorizada; un administrador debe autorizar la cuenta del usuario para que pueda acceder a las áreas del sitio web restringidas a los miembros de **Registered User**. |
| **Contraseña aleatoria**  | Si está activado (**On**), genera una contraseña al azar. De lo contrario, debderá proporcionar una contraseña. |
| **Contraseña** | Si el sitio se ha configurado con reglas de contraseña (p.ej., longitud mínima), la contraseña inicial que elija deberá cumplir esas reglas. |
| **Enviar un email al nuevo usuario** | Si está marcado, el usuario será notificado por correo electrónico de la creación de la cuenta. Se puede marcar más adelante para enviar cuando sea oportuno. |