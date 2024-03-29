using DFKContracts.ERC20.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using System.Numerics;

namespace DFKContracts.ERC20
{
	public partial class Erc20Service
	{
		public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Erc20Deployment erc20Deployment, CancellationTokenSource cancellationTokenSource = null)
		{
			return web3.Eth.GetContractDeploymentHandler<Erc20Deployment>().SendRequestAndWaitForReceiptAsync(erc20Deployment, cancellationTokenSource);
		}

		public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Erc20Deployment erc20Deployment)
		{
			return web3.Eth.GetContractDeploymentHandler<Erc20Deployment>().SendRequestAsync(erc20Deployment);
		}

		public static async Task<Erc20Service> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Erc20Deployment erc20Deployment, CancellationTokenSource cancellationTokenSource = null)
		{
			var receipt = await DeployContractAndWaitForReceiptAsync(web3, erc20Deployment, cancellationTokenSource);
			return new Erc20Service(web3, receipt.ContractAddress);
		}

		protected Nethereum.Web3.Web3 Web3 { get; }

		public ContractHandler ContractHandler { get; }

		public Erc20Service(Nethereum.Web3.Web3 web3, string contractAddress)
		{
			Web3 = web3;
			ContractHandler = web3.Eth.GetContractHandler(contractAddress);
		}

		public Task<BigInteger> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
		}


		public Task<BigInteger> AllowanceQueryAsync(string owner, string spender, BlockParameter blockParameter = null)
		{
			var allowanceFunction = new AllowanceFunction();
			allowanceFunction.Owner = owner;
			allowanceFunction.Spender = spender;

			return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
		}

		public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
		{
			return ContractHandler.SendRequestAsync(approveFunction);
		}

		public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
		{
			return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
		}

		public Task<string> ApproveRequestAsync(string spender, BigInteger amount)
		{
			var approveFunction = new ApproveFunction();
			approveFunction.Spender = spender;
			approveFunction.Amount = amount;

			return ContractHandler.SendRequestAsync(approveFunction);
		}

		public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string spender, BigInteger amount, CancellationTokenSource cancellationToken = null)
		{
			var approveFunction = new ApproveFunction();
			approveFunction.Spender = spender;
			approveFunction.Amount = amount;

			return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
		}

		public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
		}


		public Task<BigInteger> BalanceOfQueryAsync(string account, BlockParameter blockParameter = null)
		{
			var balanceOfFunction = new BalanceOfFunction();
			balanceOfFunction.Account = account;

			return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
		}

		public Task<byte> DecimalsQueryAsync(DecimalsFunction decimalsFunction, BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<DecimalsFunction, byte>(decimalsFunction, blockParameter);
		}


		public Task<byte> DecimalsQueryAsync(BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<DecimalsFunction, byte>(null, blockParameter);
		}

		public Task<string> DecreaseAllowanceRequestAsync(DecreaseAllowanceFunction decreaseAllowanceFunction)
		{
			return ContractHandler.SendRequestAsync(decreaseAllowanceFunction);
		}

		public Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(DecreaseAllowanceFunction decreaseAllowanceFunction, CancellationTokenSource cancellationToken = null)
		{
			return ContractHandler.SendRequestAndWaitForReceiptAsync(decreaseAllowanceFunction, cancellationToken);
		}

		public Task<string> DecreaseAllowanceRequestAsync(string spender, BigInteger subtractedValue)
		{
			var decreaseAllowanceFunction = new DecreaseAllowanceFunction();
			decreaseAllowanceFunction.Spender = spender;
			decreaseAllowanceFunction.SubtractedValue = subtractedValue;

			return ContractHandler.SendRequestAsync(decreaseAllowanceFunction);
		}

		public Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(string spender, BigInteger subtractedValue, CancellationTokenSource cancellationToken = null)
		{
			var decreaseAllowanceFunction = new DecreaseAllowanceFunction();
			decreaseAllowanceFunction.Spender = spender;
			decreaseAllowanceFunction.SubtractedValue = subtractedValue;

			return ContractHandler.SendRequestAndWaitForReceiptAsync(decreaseAllowanceFunction, cancellationToken);
		}

		public Task<string> IncreaseAllowanceRequestAsync(IncreaseAllowanceFunction increaseAllowanceFunction)
		{
			return ContractHandler.SendRequestAsync(increaseAllowanceFunction);
		}

		public Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(IncreaseAllowanceFunction increaseAllowanceFunction, CancellationTokenSource cancellationToken = null)
		{
			return ContractHandler.SendRequestAndWaitForReceiptAsync(increaseAllowanceFunction, cancellationToken);
		}

		public Task<string> IncreaseAllowanceRequestAsync(string spender, BigInteger addedValue)
		{
			var increaseAllowanceFunction = new IncreaseAllowanceFunction();
			increaseAllowanceFunction.Spender = spender;
			increaseAllowanceFunction.AddedValue = addedValue;

			return ContractHandler.SendRequestAsync(increaseAllowanceFunction);
		}

		public Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(string spender, BigInteger addedValue, CancellationTokenSource cancellationToken = null)
		{
			var increaseAllowanceFunction = new IncreaseAllowanceFunction();
			increaseAllowanceFunction.Spender = spender;
			increaseAllowanceFunction.AddedValue = addedValue;

			return ContractHandler.SendRequestAndWaitForReceiptAsync(increaseAllowanceFunction, cancellationToken);
		}

		public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
		}


		public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
		}

		public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
		}


		public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
		}

		public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
		}


		public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
		{
			return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
		}

		public Task<string> TransferRequestAsync(TransferFunction transferFunction)
		{
			return ContractHandler.SendRequestAsync(transferFunction);
		}

		public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationTokenSource cancellationToken = null)
		{
			return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
		}

		public Task<string> TransferRequestAsync(string to, BigInteger amount)
		{
			var transferFunction = new TransferFunction();
			transferFunction.To = to;
			transferFunction.Amount = amount;

			return ContractHandler.SendRequestAsync(transferFunction);
		}

		public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(string to, BigInteger amount, CancellationTokenSource cancellationToken = null)
		{
			var transferFunction = new TransferFunction();
			transferFunction.To = to;
			transferFunction.Amount = amount;

			return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
		}

		public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
		{
			return ContractHandler.SendRequestAsync(transferFromFunction);
		}

		public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
		{
			return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
		}

		public Task<string> TransferFromRequestAsync(string from, string to, BigInteger amount)
		{
			var transferFromFunction = new TransferFromFunction();
			transferFromFunction.From = from;
			transferFromFunction.To = to;
			transferFromFunction.Amount = amount;

			return ContractHandler.SendRequestAsync(transferFromFunction);
		}

		public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger amount, CancellationTokenSource cancellationToken = null)
		{
			var transferFromFunction = new TransferFromFunction();
			transferFromFunction.From = from;
			transferFromFunction.To = to;
			transferFromFunction.Amount = amount;

			return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
		}
	}
}
