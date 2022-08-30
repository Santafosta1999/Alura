const Operacoes = require('../../infraestrutura/operations');
const Cliente = new Operacoes('cliente');

const resolvers = {
    Query: {
      clientes: () => Cliente.lista(),
      cliente: (root, { id }) => Cliente.buscaPorId(id),
    },
    Mutation: {
      adicionarCliente: (root, params) => Cliente.adiciona(params),
      atualizarCliente: (root, params) => Cliente.atualiza(params),
      deletarCliente: (root, { id }) => Cliente.deleta(id)
    }
}

module.exports = resolvers;