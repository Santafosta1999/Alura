const LivroControlador = require('../controllers/livro-controller');
const livroControlador = new LivroControlador();

const Livro = require('../models/livro');

const BaseControlador = require('../controllers/base-controller');

module.exports = (app) => {
    const rotasLivro = LivroControlador.rotas();
    
    app.use(rotasLivro.autenticadas, function(req, resp, next) {
        if(req.isAuthenticated()) {
            next();
        } else {
            resp.redirect(BaseControlador.rotas().login);
        }
    });

    app.get(rotasLivro.lista, livroControlador.lista());

    app.route(rotasLivro.cadastro)
        .get(livroControlador.formularioCadastro())
        .post(Livro.validacoes(),livroControlador.adiciona())
        .put(livroControlador.atualiza());

    app.get(rotasLivro.edicao, livroControlador.formularioEdicao());

    app.delete(rotasLivro.delecao, livroControlador.deleta());
};