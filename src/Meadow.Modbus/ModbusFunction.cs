namespace Meadow.Modbus
{
    public enum ModbusFunction : byte
    {
        ReadCoil = 1, // Incorrect
        ReadCoils = 1, // Correct
        ReadDiscrete = 2, // Incorrect
        ReadDiscreteInputs = 2, // Correct
        ReadHoldingRegister = 3, // Incorrect
        ReadHoldingRegisters = 3, // Correct
        ReadInputRegister = 4, // Incorrect
        ReadInputRegisters = 4, // Correct
        WriteCoil = 5, // Incorrect
        WriteSingleCoil = 5, // Correct
        WriteRegister = 6, // Incorrect
        WriteSingleRegister = 6, // Correct
        WriteMultipleCoils = 15,
        WriteMultipleRegisters = 16,
        ReadWriteMultipleRegisters = 23
    }
}
