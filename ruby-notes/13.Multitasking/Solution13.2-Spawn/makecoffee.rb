require 'benchmark'

# SEQUENTIAL
puts Benchmark.measure {
  puts `ruby boilwater.rb`
  puts `ruby grindbeans.rb`
  puts `ruby prepcup.rb`
  puts
  puts "MADE COFFEE SEQ"
}.real.round(1).to_s + 's '


# ASYNC. (PARALLEL)
puts Benchmark.measure {
  bw = spawn(RbConfig.ruby, 'boilwater.rb')
  gb = spawn(RbConfig.ruby, 'grindbeans.rb')
  pc = spawn(RbConfig.ruby, 'prepcup.rb')

  Process.wait(bw)
  Process.wait(gb)
  Process.wait(pc)

  puts
  puts "MADE COFFEE PAR"
}.real.round(1).to_s + 's '

abort("done!")