﻿using Business.Notificacoes;
using DevIO.Business.Notificacoes;

namespace Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}