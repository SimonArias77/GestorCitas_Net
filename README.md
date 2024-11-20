# Sistema de Gestión de Citas para Clínica Privada

## Descripción

Este proyecto simula un sistema de gestión de citas para una clínica privada con el objetivo de resolver varios problemas comunes que enfrenta la clínica. Estos incluyen conflictos de horario, citas duplicadas, falta de historial de citas, y dificultad para visualizar la disponibilidad de los médicos.

El sistema está diseñado para mejorar la eficiencia del proceso de agendamiento de citas, garantizando que los médicos no tengan citas solapadas, permitiendo un fácil seguimiento de las citas pasadas de los pacientes, y facilitando la visualización de la disponibilidad de los médicos de forma clara.

## Problemas a Resolver

### 1. Conflictos de horario
- El sistema previene que se registren dos citas al mismo tiempo para un mismo médico.
- Permite verificar la disponibilidad de los médicos en tiempo real al momento de agendar citas.

### 2. Citas duplicadas
- Evita que un paciente reciba confirmaciones duplicadas para una misma cita o que se agenden varias citas para el mismo problema médico.

### 3. Falta de seguimiento del historial de citas
- Mantiene un historial detallado de las citas pasadas de cada paciente, accesible para el personal administrativo y los médicos, facilitando la revisión de citas anteriores sin perder información valiosa.

### 4. Dificultad para visualizar la disponibilidad de los médicos
- Ofrece una vista clara y centralizada de la disponibilidad de los médicos, lo que agiliza el proceso de agendamiento y evita la sobrecarga de gestión manual.

## Objetivos de la Solución

- **Acceso por Roles**: Diferentes usuarios (como médicos y pacientes) pueden acceder al sistema según su rol desde distintas ubicaciones, incluso fuera de la clínica.
- **Organización Centralizada**: Toda la información relacionada con las citas se mantiene organizada y centralizada, evitando duplicaciones o confusión.
- **Visualización de Disponibilidad**: El sistema proporciona una vista clara y fácil de actualizar sobre la disponibilidad de los médicos y las citas programadas.
- **Facilidad de Uso**: El sistema es fácil de usar para cualquier persona, independientemente de su experiencia técnica.
- **Escalabilidad**: El sistema es flexible y preparado para crecer, permitiendo la integración de nuevas funcionalidades o herramientas en el futuro.

## Funcionalidades Clave

- **Gestión de Usuarios**:
  - Los usuarios deben poder registrarse y loguearse según su rol (médico, paciente, administrador).
  - Los usuarios solo pueden ver la información que es pertinente a su rol.
  
- **Gestión de Citas**:
  - El sistema impide que se agenden dos citas para el mismo médico en el mismo horario.
  - Actualización en tiempo real de la disponibilidad de los médicos cuando se agenda una cita.
  - Advertencias al intentar agendar una cita en un horario ya ocupado.
  - Información sobre el motivo de cada cita.
  
- **Filtros de Citas**:
  - Permite filtrar las citas por fecha, especialidad o motivo.
  
- **Notas y Comentarios**:
  - Permite agregar notas o comentarios adicionales a cada cita para personalizar el registro.

## Criterios de Aceptación

- El sistema debe permitir a los usuarios registrarse, loguearse e interactuar con la base de datos según su rol (médico, paciente, administrador).
- No debe permitir agendar dos citas en el mismo horario para un médico.
- Debe actualizar la disponibilidad en tiempo real cuando se agende una cita.
- Debe mostrar advertencias si un usuario intenta agendar una cita en un horario ocupado.
- Debe incluir información sobre el motivo de cada cita.
- Los usuarios deben poder filtrar las citas por fecha, especialidad o motivo.
- Los usuarios deben poder agregar notas o comentarios a cada cita.
- Los usuarios solo deben poder ver la información que es pertinente a su rol.

## Instalación

### Requisitos Previos

- .NET 6 o superior
- MySQL o base de datos compatible
- Herramientas de desarrollo como Visual Studio o VS Code

### Pasos para la Instalación

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/tuusuario/sistema-gestion-citas-clinica.git


# Enlace Repositorio GitHub:
https://github.com/SimonArias77/GestorCitas_Net
 


# CREDENCIALES PARA CONECTARSE A LA BASE DE DATOS Y PODER UTILIZAR LAS CONFI DEL JWT:

# Variables para poner las credenciales de la base de datos.
DB_HOST = bkbutgyqllphqijipmlt-mysql.services.clever-cloud.com
DB_PORT = 3306
DB_DATABASE = bkbutgyqllphqijipmlt
DB_USERNAME = uyinknp6nfeswtmm
DB_PASSWORD = QM9Q8mFa4QjBesMeztyL

# Variables para poner las configuraciones del JWT
JWT_KEY = llavesita757575jfeiofje8474576ff898hw3e73hdfv08r8ghvefhe8fj884375vunf8e88h85
JWT_ISSUER = http://localhost:5065
JWT_AUDIENCE = public
JWT_EXPIREMINUTES = 60

