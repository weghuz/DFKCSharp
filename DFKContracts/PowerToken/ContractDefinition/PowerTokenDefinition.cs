using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace PirateQuester.PowerToken.ContractDefinition
{


	public partial class PowerTokenDeployment : PowerTokenDeploymentBase
	{
		public PowerTokenDeployment() : base(BYTECODE) { }
		public PowerTokenDeployment(string byteCode) : base(byteCode) { }
	}

	public class PowerTokenDeploymentBase : ContractDeploymentMessage
	{
		public static string BYTECODE = "60806040526000600c55600f805461ffff19166127101790556203f4806012553480156200002c57600080fd5b506040516200220b3803806200220b8339810160408190526200004f91620002c2565b8551869086906200006890600390602085019062000165565b5080516200007e90600490602084019062000165565b5050506200009b620000956200010f60201b60201c565b62000113565b600793909355600b91909155600955600a55505033600090815260106020526040808220805460ff1990811660019081179092557f6e0956cda88cad152e89927e53611735b61a5c762d1428573c6931b0a5efcb0180548216831790553084529190922080549091169091179055620003a4565b3390565b600580546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b828054620001739062000351565b90600052602060002090601f016020900481019282620001975760008555620001e2565b82601f10620001b257805160ff1916838001178555620001e2565b82800160010185558215620001e2579182015b82811115620001e2578251825591602001919060010190620001c5565b50620001f0929150620001f4565b5090565b5b80821115620001f05760008155600101620001f5565b600082601f8301126200021d57600080fd5b81516001600160401b03808211156200023a576200023a6200038e565b604051601f8301601f19908116603f011681019082821181831017156200026557620002656200038e565b816040528381526020925086838588010111156200028257600080fd5b600091505b83821015620002a6578582018301518183018401529082019062000287565b83821115620002b85760008385830101525b9695505050505050565b60008060008060008060c08789031215620002dc57600080fd5b86516001600160401b0380821115620002f457600080fd5b620003028a838b016200020b565b975060208901519150808211156200031957600080fd5b506200032889828a016200020b565b95505060408701519350606087015192506080870151915060a087015190509295509295509295565b600181811c908216806200036657607f821691505b602082108114156200038857634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b611e5780620003b46000396000f3fe608060405234801561001057600080fd5b50600436106102745760003560e01c80639262c5b711610151578063c38533c6116100c3578063e4c5ff4611610087578063e4c5ff4614610590578063e6b2fb4a146105a3578063f2fde38b146105ac578063f85b84a4146105bf578063fd3d27b8146105c8578063ff3e5e45146105d057600080fd5b8063c38533c6146104fe578063c7f59a6714610511578063cf1c316a14610524578063dc7887a414610537578063dd62ed3e1461055757600080fd5b8063a457c2d711610115578063a457c2d714610492578063a69df4b5146104a5578063a9059cbb146104ad578063a9e75723146104c0578063af2b0f66146104c8578063b9181611146104db57600080fd5b80639262c5b7146104465780639358928b1461044f57806395d89b411461045757806396d7da741461045f578063a3a7e7f31461047f57600080fd5b80633a1aae35116101ea5780635a46d3b5116101ae5780635a46d3b5146103b55780636a141e2c146103de57806370a08231146103f1578063715018a61461041a5780638c8b292b146104225780638da5cb5b1461042b57600080fd5b80633a1aae35146103525780633ff8bf2e1461035b57806340c10f191461037c578063485d7d941461038f5780634b0ee02a146103a257600080fd5b8063202b17601161023c578063202b1760146102ee57806323b872dd14610301578063282d3fdf14610314578063313ce56714610327578063355274ea14610336578063395093511461033f57600080fd5b806306fdde0314610279578063095ea7b3146102975780630cb285e2146102ba57806314a8cea3146102cf57806318160ddd146102e6575b600080fd5b6102816105e3565b60405161028e9190611c9f565b60405180910390f35b6102aa6102a5366004611c38565b610675565b604051901515815260200161028e565b6102cd6102c8366004611c86565b61068d565b005b6102d860095481565b60405190815260200161028e565b6002546102d8565b6102d86102fc366004611b72565b6106ee565b6102aa61030f366004611bc0565b6107b4565b6102cd610322366004611c38565b6107d8565b6040516012815260200161028e565b6102d860075481565b6102aa61034d366004611c38565b6109c6565b6102d860085481565b600f546103699061ffff1681565b60405161ffff909116815260200161028e565b6102cd61038a366004611c38565b610a05565b6102cd61039d366004611b72565b610a3d565b6102d86103b0366004611b72565b610a9e565b6102d86103c3366004611b72565b6001600160a01b03166000908152600d602052604090205490565b6102cd6103ec366004611c62565b610acf565b6102d86103ff366004611b72565b6001600160a01b031660009081526020819052604090205490565b6102cd610cb0565b6102d860125481565b6005546040516001600160a01b03909116815260200161028e565b6102d8600a5481565b6102d8610ce6565b610281610cf6565b6102d861046d366004611b72565b60116020526000908152604090205481565b6102cd61048d366004611b72565b610d05565b6102aa6104a0366004611c38565b610f30565b6102cd610fc2565b6102aa6104bb366004611c38565b610fd9565b6102d8610fe7565b6102cd6104d6366004611c38565b61100c565b6102aa6104e9366004611b72565b60066020526000908152604090205460ff1681565b6102cd61050c366004611c86565b61108b565b6102cd61051f366004611bfc565b6110e3565b6102cd610532366004611b72565b611161565b6102d8610545366004611b72565b600e6020526000908152604090205481565b6102d8610565366004611b8d565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b6102cd61059e366004611c38565b6111af565b6102d8600c5481565b6102cd6105ba366004611b72565b61128c565b6102d8600b5481565b6102d8611324565b6102cd6105de366004611c86565b61133b565b6060600380546105f290611dd0565b80601f016020809104026020016040519081016040528092919081815260200182805461061e90611dd0565b801561066b5780601f106106405761010080835404028352916020019161066b565b820191906000526020600020905b81548152906001019060200180831161064e57829003601f168201915b5050505050905090565b600033610683818585611393565b5060019392505050565b3360009081526006602052604090205460ff16806106c45750336106b96005546001600160a01b031690565b6001600160a01b0316145b6106e95760405162461bcd60e51b81526004016106e090611d29565b60405180910390fd5b600a55565b600060095442101561070257506000919050565b600a54421061072757506001600160a01b03166000908152600d602052604090205490565b6001600160a01b0382166000908152600e602052604081205461074b9042906114b7565b6001600160a01b0384166000908152600e6020526040812054600a549293509091610775916114b7565b6001600160a01b0385166000908152600d60205260409020549091506107a79082906107a190856114ca565b906114d6565b949350505050565b919050565b6000336107c28582856114e2565b6107cd858585611574565b506001949350505050565b3360009081526006602052604090205460ff168061080f5750336108046005546001600160a01b031690565b6001600160a01b0316145b61082b5760405162461bcd60e51b81526004016106e090611d29565b6001600160a01b0382166108815760405162461bcd60e51b815260206004820152601f60248201527f43616e6e6f74206c6f636b20746f20746865207a65726f20616464726573730060448201526064016106e0565b6001600160a01b0382166000908152602081905260409020548111156108e95760405162461bcd60e51b815260206004820152601860248201527f4c6f636b20616d6f756e74206f7665722062616c616e6365000000000000000060448201526064016106e0565b6108f4823083611574565b6001600160a01b0382166000908152600d6020526040902054610917908261165e565b6001600160a01b0383166000908152600d602052604090205560085461093d908261165e565b6008556009546001600160a01b0383166000908152600e6020526040902054101561097f576009546001600160a01b0383166000908152600e60205260409020555b816001600160a01b03167f625fed9875dada8643f2418b838ae0bc78d9a148a18eee4ee1979ff0f3f5d427826040516109ba91815260200190565b60405180910390a25050565b3360008181526001602090815260408083206001600160a01b03871684529091528120549091906106839082908690610a00908790611d60565b611393565b6005546001600160a01b03163314610a2f5760405162461bcd60e51b81526004016106e090611cf4565b610a39828261166a565b5050565b6005546001600160a01b03163314610a675760405162461bcd60e51b81526004016106e090611cf4565b6001600160a01b038116331415610a7d57600080fd5b6001600160a01b03166000908152600660205260409020805460ff19169055565b6001600160a01b03811660009081526020818152604080832054600d909252822054610ac99161165e565b92915050565b3360009081526006602052604090205460ff1680610b06575033610afb6005546001600160a01b031690565b6001600160a01b0316145b610b225760405162461bcd60e51b81526004016106e090611d29565b6127108161ffff161115610bc45760405162461bcd60e51b815260206004820152605760248201527f7570646174654d61785472616e73666572416d6f756e74526174653a204d617860448201527f207472616e7366657220616d6f756e742072617465206d757374206e6f74206560648201527f786365656420746865206d6178696d756d20726174652e000000000000000000608482015260a4016106e0565b60328161ffff161015610c565760405162461bcd60e51b815260206004820152604e60248201527f7570646174654d61785472616e73666572416d6f756e74526174653a204d617860448201527f207472616e7366657220616d6f756e742072617465206d757374206265206d6f60648201526d3932903a3430b710181718181a9760911b608482015260a4016106e0565b600f546040805161ffff928316815291831660208301527fff6316521befb2f41341a167cc0af9a05541f2b9d73de40cba35c37d34e87e6f910160405180910390a1600f805461ffff191661ffff92909216919091179055565b6005546001600160a01b03163314610cda5760405162461bcd60e51b81526004016106e090611cf4565b610ce46000611755565b565b6000610cf160025490565b905090565b6060600480546105f290611dd0565b601254610d129042611db9565b3360009081526011602052604090205410610d685760405162461bcd60e51b81526020600482015260166024820152753a3930b739b332b91030b6361031b7b7b6103237bbb760511b60448201526064016106e0565b601254610d759042611db9565b6001600160a01b03821660009081526011602052604090205410610dd45760405162461bcd60e51b81526020600482015260166024820152753a3930b739b332b91030b6361031b7b7b6103237bbb760511b60448201526064016106e0565b3360008181526011602052604080822042908190556001600160a01b03851680845291909220919091551415610e3c5760405162461bcd60e51b815260206004820152600d60248201526c39b2b633103a3930b739b332b960991b60448201526064016106e0565b336000908152600d6020526040808220546001600160a01b0384168352912054610e669190611d60565b6001600160a01b0382166000908152600d6020908152604080832093909355600954600e909152919020541015610eb4576009546001600160a01b0382166000908152600e60205260409020555b336000908152600e6020526040808220546001600160a01b03841683529120541015610efb57336000908152600e6020526040808220546001600160a01b03841683529120555b336000818152600d60209081526040808320839055600e825280832083905590829052902054610f2d91908390611574565b50565b3360008181526001602090815260408083206001600160a01b038716845290915281205490919083811015610fb55760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016106e0565b6107cd8286868403611393565b6000610fcd336106ee565b9050610f2d33826117a7565b600033610683818585611574565b600f54600090610cf190612710906107a19061ffff1661100660025490565b906114ca565b3360009081526006602052604090205460ff16806110435750336110386005546001600160a01b031690565b6001600160a01b0316145b61105f5760405162461bcd60e51b81526004016106e090611d29565b600061106a836106ee565b9050801561107c5761107c83826117a7565b61108683836117a7565b505050565b3360009081526006602052604090205460ff16806110c25750336110b76005546001600160a01b031690565b6001600160a01b0316145b6110de5760405162461bcd60e51b81526004016106e090611d29565b600955565b3360009081526006602052604090205460ff168061111a57503361110f6005546001600160a01b031690565b6001600160a01b0316145b6111365760405162461bcd60e51b81526004016106e090611d29565b6001600160a01b03919091166000908152601060205260409020805460ff1916911515919091179055565b6005546001600160a01b0316331461118b5760405162461bcd60e51b81526004016106e090611cf4565b6001600160a01b03166000908152600660205260409020805460ff19166001179055565b3360009081526006602052604090205460ff16806111e65750336111db6005546001600160a01b031690565b6001600160a01b0316145b6112025760405162461bcd60e51b81526004016106e090611d29565b600b54600c541061126e5760405162461bcd60e51b815260206004820152603060248201527f45524332303a206d616e75616c4d696e7465642067726561746572207468616e60448201526f081b585b9d585b135a5b9d131a5b5a5d60821b60648201526084016106e0565b611278828261166a565b600c54611285908261165e565b600c555050565b6005546001600160a01b031633146112b65760405162461bcd60e51b81526004016106e090611cf4565b6001600160a01b03811661131b5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016106e0565b610f2d81611755565b6000610cf160085461133560025490565b906114b7565b3360009081526006602052604090205460ff16806113725750336113676005546001600160a01b031690565b6001600160a01b0316145b61138e5760405162461bcd60e51b81526004016106e090611d29565b601255565b6001600160a01b0383166113f55760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016106e0565b6001600160a01b0382166114565760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016106e0565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b60006114c38284611db9565b9392505050565b60006114c38284611d9a565b60006114c38284611d78565b6001600160a01b03838116600090815260016020908152604080832093861683529290522054600019811461156e57818110156115615760405162461bcd60e51b815260206004820152601d60248201527f45524332303a20696e73756666696369656e7420616c6c6f77616e636500000060448201526064016106e0565b61156e8484848403611393565b50505050565b8282826000611581610fe7565b111561164b576001600160a01b03831660009081526010602052604090205460ff161580156115c957506001600160a01b03821660009081526010602052604090205460ff16155b1561164b576115d6610fe7565b81111561164b5760405162461bcd60e51b815260206004820152603860248201527f616e74695768616c653a205472616e7366657220616d6f756e7420657863656560448201527f647320746865206d61785472616e73666572416d6f756e74000000000000000060648201526084016106e0565b611656868686611910565b505050505050565b60006114c38284611d60565b6001600160a01b0382166116c05760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016106e0565b6116cc60008383611ae9565b80600260008282546116de9190611d60565b90915550506001600160a01b0382166000908152602081905260408120805483929061170b908490611d60565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b600580546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6001600160a01b0382166000908152600d602052604090205461180c5760405162461bcd60e51b815260206004820152601a60248201527f496e73756666696369656e74206c6f636b656420746f6b656e7300000000000060448201526064016106e0565b6001600160a01b0382166000908152600d602052604090205481111561184757506001600160a01b0381166000908152600d60205260409020545b306000908152602081905260409020548111156118705750306000908152602081905260409020545b61187b308383611574565b6001600160a01b0382166000908152600d602052604090205461189e90826114b7565b6001600160a01b0383166000908152600d6020908152604080832093909355600e9052204390556008546118d290826114b7565b6008556040518181526001600160a01b038316907f6381d9813cabeb57471b5a7e05078e64845ccdb563146a6911d536f24ce960f1906020016109ba565b6001600160a01b0383166119745760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016106e0565b6001600160a01b0382166119d65760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016106e0565b6119e1838383611ae9565b6001600160a01b03831660009081526020819052604090205481811015611a595760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016106e0565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290611a90908490611d60565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051611adc91815260200190565b60405180910390a361156e565b6001600160a01b03831661108657600754611b0d82611b0760025490565b9061165e565b11156110865760405162461bcd60e51b815260206004820152601960248201527f45524332304361707065643a206361702065786365656465640000000000000060448201526064016106e0565b80356001600160a01b03811681146107af57600080fd5b600060208284031215611b8457600080fd5b6114c382611b5b565b60008060408385031215611ba057600080fd5b611ba983611b5b565b9150611bb760208401611b5b565b90509250929050565b600080600060608486031215611bd557600080fd5b611bde84611b5b565b9250611bec60208501611b5b565b9150604084013590509250925092565b60008060408385031215611c0f57600080fd5b611c1883611b5b565b915060208301358015158114611c2d57600080fd5b809150509250929050565b60008060408385031215611c4b57600080fd5b611c5483611b5b565b946020939093013593505050565b600060208284031215611c7457600080fd5b813561ffff811681146114c357600080fd5b600060208284031215611c9857600080fd5b5035919050565b600060208083528351808285015260005b81811015611ccc57858101830151858201604001528201611cb0565b81811115611cde576000604083870101525b50601f01601f1916929092016040019392505050565b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b60208082526018908201527f63616c6c6572206973206e6f7420617574686f72697a65640000000000000000604082015260600190565b60008219821115611d7357611d73611e0b565b500190565b600082611d9557634e487b7160e01b600052601260045260246000fd5b500490565b6000816000190483118215151615611db457611db4611e0b565b500290565b600082821015611dcb57611dcb611e0b565b500390565b600181811c90821680611de457607f821691505b60208210811415611e0557634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fdfea2646970667358221220fc668c9017b49239ca47a2b89373711f127b96660e5cf5657e6f510cb8fa13aa64736f6c6343000806003300000000000000000000000000000000000000000000000000000000000000c000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000006765c793fa10079d000000000000000000000000000000000000000000000000027b46536c66c8e30000000000000000000000000000000000000000000000000000000000000064262280000000000000000000000000000000000000000000000000000000006608a78000000000000000000000000000000000000000000000000000000000000000084372797374616c7300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000074352595354414c00000000000000000000000000000000000000000000000000";
		public PowerTokenDeploymentBase() : base(BYTECODE) { }
		public PowerTokenDeploymentBase(string byteCode) : base(byteCode) { }
		[Parameter("string", "_name", 1)]
		public virtual string Name { get; set; }
		[Parameter("string", "_symbol", 2)]
		public virtual string Symbol { get; set; }
		[Parameter("uint256", "_cap", 3)]
		public virtual BigInteger Cap { get; set; }
		[Parameter("uint256", "_manualMintLimit", 4)]
		public virtual BigInteger ManualMintLimit { get; set; }
		[Parameter("uint256", "_lockFromTime", 5)]
		public virtual BigInteger LockFromTime { get; set; }
		[Parameter("uint256", "_lockToTime", 6)]
		public virtual BigInteger LockToTime { get; set; }
	}

	public partial class AddAuthorizedFunction : AddAuthorizedFunctionBase { }

	[Function("addAuthorized")]
	public class AddAuthorizedFunctionBase : FunctionMessage
	{
		[Parameter("address", "_toAdd", 1)]
		public virtual string ToAdd { get; set; }
	}

	public partial class AllowanceFunction : AllowanceFunctionBase { }

	[Function("allowance", "uint256")]
	public class AllowanceFunctionBase : FunctionMessage
	{
		[Parameter("address", "owner", 1)]
		public virtual string Owner { get; set; }
		[Parameter("address", "spender", 2)]
		public virtual string Spender { get; set; }
	}

	public partial class ApproveFunction : ApproveFunctionBase { }

	[Function("approve", "bool")]
	public class ApproveFunctionBase : FunctionMessage
	{
		[Parameter("address", "spender", 1)]
		public virtual string Spender { get; set; }
		[Parameter("uint256", "amount", 2)]
		public virtual BigInteger Amount { get; set; }
	}

	public partial class AuthorizedFunction : AuthorizedFunctionBase { }

	[Function("authorized", "bool")]
	public class AuthorizedFunctionBase : FunctionMessage
	{
		[Parameter("address", "", 1)]
		public virtual string ReturnValue1 { get; set; }
	}

	public partial class BalanceOfFunction : BalanceOfFunctionBase { }

	[Function("balanceOf", "uint256")]
	public class BalanceOfFunctionBase : FunctionMessage
	{
		[Parameter("address", "account", 1)]
		public virtual string Account { get; set; }
	}

	public partial class CanUnlockAmountFunction : CanUnlockAmountFunctionBase { }

	[Function("canUnlockAmount", "uint256")]
	public class CanUnlockAmountFunctionBase : FunctionMessage
	{
		[Parameter("address", "_holder", 1)]
		public virtual string Holder { get; set; }
	}

	public partial class CapFunction : CapFunctionBase { }

	[Function("cap", "uint256")]
	public class CapFunctionBase : FunctionMessage
	{

	}

	public partial class CirculatingSupplyFunction : CirculatingSupplyFunctionBase { }

	[Function("circulatingSupply", "uint256")]
	public class CirculatingSupplyFunctionBase : FunctionMessage
	{

	}

	public partial class DecimalsFunction : DecimalsFunctionBase { }

	[Function("decimals", "uint8")]
	public class DecimalsFunctionBase : FunctionMessage
	{

	}

	public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

	[Function("decreaseAllowance", "bool")]
	public class DecreaseAllowanceFunctionBase : FunctionMessage
	{
		[Parameter("address", "spender", 1)]
		public virtual string Spender { get; set; }
		[Parameter("uint256", "subtractedValue", 2)]
		public virtual BigInteger SubtractedValue { get; set; }
	}

	public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

	[Function("increaseAllowance", "bool")]
	public class IncreaseAllowanceFunctionBase : FunctionMessage
	{
		[Parameter("address", "spender", 1)]
		public virtual string Spender { get; set; }
		[Parameter("uint256", "addedValue", 2)]
		public virtual BigInteger AddedValue { get; set; }
	}

	public partial class LastUnlockTimeFunction : LastUnlockTimeFunctionBase { }

	[Function("lastUnlockTime", "uint256")]
	public class LastUnlockTimeFunctionBase : FunctionMessage
	{
		[Parameter("address", "", 1)]
		public virtual string ReturnValue1 { get; set; }
	}

	public partial class LockFunction : LockFunctionBase { }

	[Function("lock")]
	public class LockFunctionBase : FunctionMessage
	{
		[Parameter("address", "_holder", 1)]
		public virtual string Holder { get; set; }
		[Parameter("uint256", "_amount", 2)]
		public virtual BigInteger Amount { get; set; }
	}

	public partial class LockFromTimeFunction : LockFromTimeFunctionBase { }

	[Function("lockFromTime", "uint256")]
	public class LockFromTimeFunctionBase : FunctionMessage
	{

	}

	public partial class LockFromUpdateFunction : LockFromUpdateFunctionBase { }

	[Function("lockFromUpdate")]
	public class LockFromUpdateFunctionBase : FunctionMessage
	{
		[Parameter("uint256", "_lockFromTime", 1)]
		public virtual BigInteger LockFromTime { get; set; }
	}

	public partial class LockOfFunction : LockOfFunctionBase { }

	[Function("lockOf", "uint256")]
	public class LockOfFunctionBase : FunctionMessage
	{
		[Parameter("address", "_holder", 1)]
		public virtual string Holder { get; set; }
	}

	public partial class LockToTimeFunction : LockToTimeFunctionBase { }

	[Function("lockToTime", "uint256")]
	public class LockToTimeFunctionBase : FunctionMessage
	{

	}

	public partial class LockToUpdateFunction : LockToUpdateFunctionBase { }

	[Function("lockToUpdate")]
	public class LockToUpdateFunctionBase : FunctionMessage
	{
		[Parameter("uint256", "_lockToTime", 1)]
		public virtual BigInteger LockToTime { get; set; }
	}

	public partial class ManualMintFunction : ManualMintFunctionBase { }

	[Function("manualMint")]
	public class ManualMintFunctionBase : FunctionMessage
	{
		[Parameter("address", "_to", 1)]
		public virtual string To { get; set; }
		[Parameter("uint256", "_amount", 2)]
		public virtual BigInteger Amount { get; set; }
	}

	public partial class ManualMintLimitFunction : ManualMintLimitFunctionBase { }

	[Function("manualMintLimit", "uint256")]
	public class ManualMintLimitFunctionBase : FunctionMessage
	{

	}

	public partial class ManualMintedFunction : ManualMintedFunctionBase { }

	[Function("manualMinted", "uint256")]
	public class ManualMintedFunctionBase : FunctionMessage
	{

	}

	public partial class MaxTransferAmountFunction : MaxTransferAmountFunctionBase { }

	[Function("maxTransferAmount", "uint256")]
	public class MaxTransferAmountFunctionBase : FunctionMessage
	{

	}

	public partial class MaxTransferAmountRateFunction : MaxTransferAmountRateFunctionBase { }

	[Function("maxTransferAmountRate", "uint16")]
	public class MaxTransferAmountRateFunctionBase : FunctionMessage
	{

	}

	public partial class MintFunction : MintFunctionBase { }

	[Function("mint")]
	public class MintFunctionBase : FunctionMessage
	{
		[Parameter("address", "_to", 1)]
		public virtual string To { get; set; }
		[Parameter("uint256", "_amount", 2)]
		public virtual BigInteger Amount { get; set; }
	}

	public partial class NameFunction : NameFunctionBase { }

	[Function("name", "string")]
	public class NameFunctionBase : FunctionMessage
	{

	}

	public partial class OwnerFunction : OwnerFunctionBase { }

	[Function("owner", "address")]
	public class OwnerFunctionBase : FunctionMessage
	{

	}

	public partial class RemoveAuthorizedFunction : RemoveAuthorizedFunctionBase { }

	[Function("removeAuthorized")]
	public class RemoveAuthorizedFunctionBase : FunctionMessage
	{
		[Parameter("address", "_toRemove", 1)]
		public virtual string ToRemove { get; set; }
	}

	public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

	[Function("renounceOwnership")]
	public class RenounceOwnershipFunctionBase : FunctionMessage
	{

	}

	public partial class SetExcludedFromAntiWhaleFunction : SetExcludedFromAntiWhaleFunctionBase { }

	[Function("setExcludedFromAntiWhale")]
	public class SetExcludedFromAntiWhaleFunctionBase : FunctionMessage
	{
		[Parameter("address", "_account", 1)]
		public virtual string Account { get; set; }
		[Parameter("bool", "_excluded", 2)]
		public virtual bool Excluded { get; set; }
	}

	public partial class SymbolFunction : SymbolFunctionBase { }

	[Function("symbol", "string")]
	public class SymbolFunctionBase : FunctionMessage
	{

	}

	public partial class TotalBalanceOfFunction : TotalBalanceOfFunctionBase { }

	[Function("totalBalanceOf", "uint256")]
	public class TotalBalanceOfFunctionBase : FunctionMessage
	{
		[Parameter("address", "_holder", 1)]
		public virtual string Holder { get; set; }
	}

	public partial class TotalLockFunction : TotalLockFunctionBase { }

	[Function("totalLock", "uint256")]
	public class TotalLockFunctionBase : FunctionMessage
	{

	}

	public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

	[Function("totalSupply", "uint256")]
	public class TotalSupplyFunctionBase : FunctionMessage
	{

	}

	public partial class TransferFunction : TransferFunctionBase { }

	[Function("transfer", "bool")]
	public class TransferFunctionBase : FunctionMessage
	{
		[Parameter("address", "to", 1)]
		public virtual string To { get; set; }
		[Parameter("uint256", "amount", 2)]
		public virtual BigInteger Amount { get; set; }
	}

	public partial class TransferAllFunction : TransferAllFunctionBase { }

	[Function("transferAll")]
	public class TransferAllFunctionBase : FunctionMessage
	{
		[Parameter("address", "_to", 1)]
		public virtual string To { get; set; }
	}

	public partial class TransferAllIntervalFunction : TransferAllIntervalFunctionBase { }

	[Function("transferAllInterval", "uint256")]
	public class TransferAllIntervalFunctionBase : FunctionMessage
	{

	}

	public partial class TransferAllIntervalUpdateFunction : TransferAllIntervalUpdateFunctionBase { }

	[Function("transferAllIntervalUpdate")]
	public class TransferAllIntervalUpdateFunctionBase : FunctionMessage
	{
		[Parameter("uint256", "_transferAllInterval", 1)]
		public virtual BigInteger TransferAllInterval { get; set; }
	}

	public partial class TransferAllTrackerFunction : TransferAllTrackerFunctionBase { }

	[Function("transferAllTracker", "uint256")]
	public class TransferAllTrackerFunctionBase : FunctionMessage
	{
		[Parameter("address", "", 1)]
		public virtual string ReturnValue1 { get; set; }
	}

	public partial class TransferFromFunction : TransferFromFunctionBase { }

	[Function("transferFrom", "bool")]
	public class TransferFromFunctionBase : FunctionMessage
	{
		[Parameter("address", "from", 1)]
		public virtual string From { get; set; }
		[Parameter("address", "to", 2)]
		public virtual string To { get; set; }
		[Parameter("uint256", "amount", 3)]
		public virtual BigInteger Amount { get; set; }
	}

	public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

	[Function("transferOwnership")]
	public class TransferOwnershipFunctionBase : FunctionMessage
	{
		[Parameter("address", "newOwner", 1)]
		public virtual string NewOwner { get; set; }
	}

	public partial class UnlockFunction : UnlockFunctionBase { }

	[Function("unlock")]
	public class UnlockFunctionBase : FunctionMessage
	{

	}

	public partial class UnlockForUserFunction : UnlockForUserFunctionBase { }

	[Function("unlockForUser")]
	public class UnlockForUserFunctionBase : FunctionMessage
	{
		[Parameter("address", "account", 1)]
		public virtual string Account { get; set; }
		[Parameter("uint256", "amount", 2)]
		public virtual BigInteger Amount { get; set; }
	}

	public partial class UnlockedSupplyFunction : UnlockedSupplyFunctionBase { }

	[Function("unlockedSupply", "uint256")]
	public class UnlockedSupplyFunctionBase : FunctionMessage
	{

	}

	public partial class UpdateMaxTransferAmountRateFunction : UpdateMaxTransferAmountRateFunctionBase { }

	[Function("updateMaxTransferAmountRate")]
	public class UpdateMaxTransferAmountRateFunctionBase : FunctionMessage
	{
		[Parameter("uint16", "_maxTransferAmountRate", 1)]
		public virtual ushort MaxTransferAmountRate { get; set; }
	}

	public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

	[Event("Approval")]
	public class ApprovalEventDTOBase : IEventDTO
	{
		[Parameter("address", "owner", 1, true)]
		public virtual string Owner { get; set; }
		[Parameter("address", "spender", 2, true)]
		public virtual string Spender { get; set; }
		[Parameter("uint256", "value", 3, false)]
		public virtual BigInteger Value { get; set; }
	}

	public partial class LockEventDTO : LockEventDTOBase { }

	[Event("Lock")]
	public class LockEventDTOBase : IEventDTO
	{
		[Parameter("address", "to", 1, true)]
		public virtual string To { get; set; }
		[Parameter("uint256", "value", 2, false)]
		public virtual BigInteger Value { get; set; }
	}

	public partial class MaxTransferAmountRateUpdatedEventDTO : MaxTransferAmountRateUpdatedEventDTOBase { }

	[Event("MaxTransferAmountRateUpdated")]
	public class MaxTransferAmountRateUpdatedEventDTOBase : IEventDTO
	{
		[Parameter("uint256", "previousRate", 1, false)]
		public virtual BigInteger PreviousRate { get; set; }
		[Parameter("uint256", "newRate", 2, false)]
		public virtual BigInteger NewRate { get; set; }
	}

	public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

	[Event("OwnershipTransferred")]
	public class OwnershipTransferredEventDTOBase : IEventDTO
	{
		[Parameter("address", "previousOwner", 1, true)]
		public virtual string PreviousOwner { get; set; }
		[Parameter("address", "newOwner", 2, true)]
		public virtual string NewOwner { get; set; }
	}

	public partial class TransferEventDTO : TransferEventDTOBase { }

	[Event("Transfer")]
	public class TransferEventDTOBase : IEventDTO
	{
		[Parameter("address", "from", 1, true)]
		public virtual string From { get; set; }
		[Parameter("address", "to", 2, true)]
		public virtual string To { get; set; }
		[Parameter("uint256", "value", 3, false)]
		public virtual BigInteger Value { get; set; }
	}

	public partial class UnlockEventDTO : UnlockEventDTOBase { }

	[Event("Unlock")]
	public class UnlockEventDTOBase : IEventDTO
	{
		[Parameter("address", "to", 1, true)]
		public virtual string To { get; set; }
		[Parameter("uint256", "value", 2, false)]
		public virtual BigInteger Value { get; set; }
	}



	public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

	[FunctionOutput]
	public class AllowanceOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}



	public partial class AuthorizedOutputDTO : AuthorizedOutputDTOBase { }

	[FunctionOutput]
	public class AuthorizedOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("bool", "", 1)]
		public virtual bool ReturnValue1 { get; set; }
	}

	public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

	[FunctionOutput]
	public class BalanceOfOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class CanUnlockAmountOutputDTO : CanUnlockAmountOutputDTOBase { }

	[FunctionOutput]
	public class CanUnlockAmountOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class CapOutputDTO : CapOutputDTOBase { }

	[FunctionOutput]
	public class CapOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class CirculatingSupplyOutputDTO : CirculatingSupplyOutputDTOBase { }

	[FunctionOutput]
	public class CirculatingSupplyOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

	[FunctionOutput]
	public class DecimalsOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint8", "", 1)]
		public virtual byte ReturnValue1 { get; set; }
	}





	public partial class LastUnlockTimeOutputDTO : LastUnlockTimeOutputDTOBase { }

	[FunctionOutput]
	public class LastUnlockTimeOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}



	public partial class LockFromTimeOutputDTO : LockFromTimeOutputDTOBase { }

	[FunctionOutput]
	public class LockFromTimeOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}



	public partial class LockOfOutputDTO : LockOfOutputDTOBase { }

	[FunctionOutput]
	public class LockOfOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class LockToTimeOutputDTO : LockToTimeOutputDTOBase { }

	[FunctionOutput]
	public class LockToTimeOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}





	public partial class ManualMintLimitOutputDTO : ManualMintLimitOutputDTOBase { }

	[FunctionOutput]
	public class ManualMintLimitOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class ManualMintedOutputDTO : ManualMintedOutputDTOBase { }

	[FunctionOutput]
	public class ManualMintedOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class MaxTransferAmountOutputDTO : MaxTransferAmountOutputDTOBase { }

	[FunctionOutput]
	public class MaxTransferAmountOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class MaxTransferAmountRateOutputDTO : MaxTransferAmountRateOutputDTOBase { }

	[FunctionOutput]
	public class MaxTransferAmountRateOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint16", "", 1)]
		public virtual ushort ReturnValue1 { get; set; }
	}



	public partial class NameOutputDTO : NameOutputDTOBase { }

	[FunctionOutput]
	public class NameOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("string", "", 1)]
		public virtual string ReturnValue1 { get; set; }
	}

	public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

	[FunctionOutput]
	public class OwnerOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("address", "", 1)]
		public virtual string ReturnValue1 { get; set; }
	}







	public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

	[FunctionOutput]
	public class SymbolOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("string", "", 1)]
		public virtual string ReturnValue1 { get; set; }
	}

	public partial class TotalBalanceOfOutputDTO : TotalBalanceOfOutputDTOBase { }

	[FunctionOutput]
	public class TotalBalanceOfOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class TotalLockOutputDTO : TotalLockOutputDTOBase { }

	[FunctionOutput]
	public class TotalLockOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}

	public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

	[FunctionOutput]
	public class TotalSupplyOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}





	public partial class TransferAllIntervalOutputDTO : TransferAllIntervalOutputDTOBase { }

	[FunctionOutput]
	public class TransferAllIntervalOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}



	public partial class TransferAllTrackerOutputDTO : TransferAllTrackerOutputDTOBase { }

	[FunctionOutput]
	public class TransferAllTrackerOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}









	public partial class UnlockedSupplyOutputDTO : UnlockedSupplyOutputDTOBase { }

	[FunctionOutput]
	public class UnlockedSupplyOutputDTOBase : IFunctionOutputDTO
	{
		[Parameter("uint256", "", 1)]
		public virtual BigInteger ReturnValue1 { get; set; }
	}


}
