# GolBet

Welcome to the **GolBet** repository! This project uses VS Code Dev Containers and Docker Compose to provide a fully configured, reproducible development environment with .NET support and an integrated SQL Server database.

---

## Prerequisites

Before starting, ensure you have the following installed on your host machine:

* [Docker Desktop](https://www.docker.com/products/docker-desktop/) (running)
* [Visual Studio Code](https://code.visualstudio.com/)
* [Dev Containers Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers) for VS Code

---

## Setup & Running Instructions

### Step 1: Clone the Repository

Clone the project to your local machine and navigate into the project directory:

```bash
git clone [https://github.com/dcanosu/GolBet.git](https://github.com/dcanosu/GolBet.git)
cd GolBet
```

### Step 2: Configure Environment Variables
Secrets such as database passwords are not committed to source control. Create your local ```.env``` file from the provided template:
```bash
cp .env.example .env
```
Open ```.env``` in your text editor and set your SQL Server ```SA``` password:
```bash
MSSQL_SA_PASSWORD=YourStrongPassword123!
```

### Step 3: Open Project in VS Code
Launch Visual Studio Code in the repository directory:
```bash
code .
```

### Step 4: Launch the Dev Container
1. Press ```F1``` (or ```Cmd+Shift+P``` on macOS) to open the Command Palette in VS Code.

2. Type and select Dev Containers: Reopen in Container.

3. Wait for VS Code to build the container stack, configure .NET tooling, and start the SQL Server database service.

## Container Architecture & Port Mappings
| Service | Container Name | Host Port | Description |
| :--- | :--- | :--- | :--- |
| **app** | Workspace | N/A | Main dev environment containing .NET SDK and workspace tooling |
| **sqlserver** | `sqlserver` | `1433` | Microsoft SQL Server 2022 instance |

## Troubleshooting
- SQL Server container fails to start: Check container logs to confirm that ```MSSQL_SA_PASSWORD``` meets SQL Server complexity policy requirements.

- Environment variables missing: Ensure ```.env``` is located at the root of the repository alongside ```docker-compose.yml```.

- Rebuilding the environment: Run Dev Containers: Rebuild Container from the VS Code Command Palette after updating configuration files.