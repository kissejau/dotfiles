local bo = vim.bo
local api = vim.api
local g = vim.g
local map = vim.api.nvim_set_keymap
local opts = {noremap = true, silent = true}


bo.expandtab = true
bo.shiftwidth = 2
bo.softtabstop = 2



require('packer').startup(
  function()
    use 'wbthomason/packer.nvim'
    use 'vim-airline/vim-airline'
    use 'nvim-treesitter/nvim-treesitter'
    use {
      'kyazdani42/nvim-tree.lua',
      requires = {
        'kyazdani42/nvim-web-devicons', -- optional, for file icons
        },
      tag = 'nightly' -- optional, updated every week. (see issue #1193)
    }
  end
)



-- Key mappings
map("i", "jk", "<esc>", opts)
map("n", "<C-t>", "<cmd>NvimTreeToggle<CR>", opts)



-- SETTINGS



