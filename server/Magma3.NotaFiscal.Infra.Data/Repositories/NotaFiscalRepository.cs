﻿using Magma3.NotaFiscal.Domain.Entities;
using Magma3.NotaFiscal.Domain.Repositories;
using Magma3.NotaFiscal.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Magma3.NotaFiscal.Infra.Data.Repositories
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        private readonly NotaFiscalDbContext _context;

        public NotaFiscalRepository(NotaFiscalDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarNotaFiscalAsync(Domain.Entities.NotaFiscal notaFiscal, CancellationToken cancellationToken = default)
        {
            await _context.NotasFiscais.AddAsync(notaFiscal, cancellationToken);
        }

        public async Task AdicionarProdutoNaNotaFiscalAsync(NotaFiscalProduto produto, CancellationToken cancellationToken = default)
        {
            await _context.NotasFiscaisProdutos.AddAsync(produto, cancellationToken);
        }

        public async Task<Domain.Entities.NotaFiscal> BuscarNotaFiscalPeloUIdAsync(Guid notaFiscalUId, CancellationToken cancellationToken = default)
        {
            var notaFiscal = await _context.NotasFiscais
                .AsNoTracking()
                .Include(x => x.Cliente)
                    .ThenInclude(x => x.Endereco)
                .Include(x => x.Cliente)
                    .ThenInclude(x => x.Celular)
                .Include(x => x.Produtos)
                    .ThenInclude(x => x.Produto)
                .FirstOrDefaultAsync(x => x.UId == notaFiscalUId, cancellationToken);

            return notaFiscal;
        }

        public async Task<List<Domain.Entities.NotaFiscal>> BuscarTodasNotasFiscaisAsync(CancellationToken cancellationToken = default)
        {
            var notasFiscais = await _context.NotasFiscais
                .AsNoTracking()
                .Include(x => x.Cliente)
                    .ThenInclude(x => x.Endereco)
                .Include(x => x.Cliente)
                    .ThenInclude(x => x.Celular)
                .Include(x => x.Produtos)
                    .ThenInclude(x => x.Produto)
                .ToListAsync(cancellationToken);

            return notasFiscais;
        }
    }
}