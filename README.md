# 🎲 Taverna Web

> **Plataforma web integrada para gerenciamento e imersão em campanhas de RPG de mesa.**

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-orange?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)
![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen?style=for-the-badge)

---

## 📖 Sumário

- [Sobre o Projeto](#-sobre-o-projeto)
- [Funcionalidades](#-funcionalidades)
- [Tecnologias](#-tecnologias)
- [Pré-requisitos](#-pré-requisitos)
- [Como Executar o Projeto](#-como-executar-o-projeto)
- [Roadmap de Desenvolvimento](#-roadmap-de-desenvolvimento)
- [Como Contribuir](#-como-contribuir)
- [Licença](#-licença)
- [Autor](#-autor)

---

## 🏰 Sobre o Projeto

O **Taverna Web** é uma solução completa para mestres e jogadores que desejam centralizar suas mesas de RPG de mesa (VTT & Gerenciador de Campanhas) em um único ambiente moderno, ágil e acessível diretamente pelo navegador.

O objetivo da plataforma é eliminar a sobrecarga de ferramentas externas durante uma sessão, reunindo em uma única interface: fichas de personagens interativas, controle de rodadas de combate, mapas táticos com tokens dinâmicos, rolagem de dados em tempo real, biblioteca de regras em PDF e trilha sonora imersiva com Spotify.

---

## ✨ Funcionalidades

### 👥 Para Mestres e Jogadores
- **Autenticação & Multi-Campanhas:** Criação e gestão de contas com suporte para criar, salvar e alternar entre múltiplas campanhas persistidas em banco de dados.
- **Fichas Interativas:** Criação e edição de fichas de personagens e NPCs, com controle dinâmico de atributos, inventário, magias e condições.
- **Rolador de Dados Confiável:** Suporte a dados poliédricos padrão (d4, d6, d8, d10, d12, d20, d100), modificadores, fórmulas customizadas e geração aleatória justa e transparente.

### ⚔️ Ferramentas Avançadas para o Mestre
- **Painel de Sessão & Combate:** Controle de ordem de iniciativa, gerenciamento de turnos/rodadas e anotações rápidas durante o jogo.
- **Mapas Táticos & Tokens Virtuais:** Suporte para upload de mapas com grid tático e tokens manipuláveis em tempo real.
- **Biblioteca de Livros & PDFs:** Upload e leitor de manuais e livros de regras em PDF com pesquisa rápida integrada para facilitar consultas de regras em plena sessão.
- **Trilha Sonora Integrada (Spotify API):** Conexão com o Spotify para controle de playlists, músicas ambientes e efeitos sonoros diretamente da mesa.

---

## 🛠️ Tecnologias Previstas

- **Backend:** [.NET 10](https://dotnet.microsoft.com/) / C# (ASP.NET Core)
- **Persistência de Dados:** Entity Framework Core & Banco de Dados Relacional
- **Comunicação em Tempo Real:** SignalR / WebSockets
- **Integrações:**
  - [Spotify Web API](https://developer.spotify.com/documentation/web-api) (Áudio e ambientação)
  - Leitor e indexador de documentos PDF

---

## 📋 Pré-requisitos

Antes de começar, certifique-se de possuir instalado em seu ambiente:

- [.NET SDK 10.0+](https://dotnet.microsoft.com/download) (versão `10.0.111` ou superior)
- [Git](https://git-scm.com/)

Para checar a versão do .NET instalada:

```bash
dotnet --version
```

---

## 🚀 Como Executar o Projeto

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/Diniz-Bruno/Taverna-Web.git
   cd Taverna-Web
   ```

2. **Restaure as dependências do projeto:**
   ```bash
   dotnet restore
   ```

3. **Configuração de Variáveis de Ambiente:**
   - Configure sua string de conexão com o banco de dados e credenciais da API do Spotify no arquivo de configuração (`appsettings.Development.json` ou `.env`).

4. **Execute a aplicação:**
   ```bash
   dotnet run
   ```

5. **Acesse no navegador:**
   - Abra a URL indicada no terminal (por padrão `http://localhost:5000` ou `https://localhost:5001`).

---

## 🗺️ Roadmap de Desenvolvimento

- [x] Concepção da arquitetura e documentação inicial
- [ ] Sistema de Autenticação e Gestão de Usuários
- [ ] Módulo de Criação de Campanhas e Fichas de Personagem
- [ ] Rolador de dados com histórico da sessão
- [ ] Painel do Mestre: Rastreador de combate e iniciativa
- [ ] Sistema de Mapas de Batalha com Tokens Dinâmicos
- [ ] Leitor e indexador de manuais em PDF
- [ ] Integração com Spotify API para ambientação sonora

---

## 🤝 Como Contribuir

Contribuições para a Taverna são muito bem-vindas! Para contribuir:

1. Faça um **Fork** do repositório
2. Crie uma branch para a sua funcionalidade/correção:
   ```bash
   git checkout -b feat/minha-feature
   ```
3. Commit suas alterações:
   ```bash
   git commit -m "feat: adiciona funcionalidade X"
   ```
4. Envie sua branch para o GitHub:
   ```bash
   git push origin feat/minha-feature
   ```
5. Abra um **Pull Request**

---

## 📄 Licença

Este projeto é distribuído sob a licença [MIT](LICENSE).

---

## 🧙 Autor

Desenvolvido por **Bruno Ribeiro Viana Diniz**  
- GitHub: [@Diniz-Bruno](https://github.com/Diniz-Bruno)

---
*Que suas rolagens sejam sempre 20 naturais! 🎲✨*